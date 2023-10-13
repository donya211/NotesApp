using Newtonsoft.Json;
using NotesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NotesApp.Services
{
    internal class FileIOServices
    {

        private readonly string _filePath;

        public FileIOServices(string filePath)
        {  
            _filePath = filePath;
        }
        public BindingList<NotesModels> LoadData() 
         {
            
            var fileExists = File.Exists(_filePath);
            if (!fileExists) 
            {
                
                File.Create(_filePath).Dispose();
                return new BindingList<NotesModels>() { new NotesModels() { Text = "Test text", IsDone = true } };
            }
            using (var stream = File.OpenText(_filePath))
            {
                var fileText = stream.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<NotesModels>>(fileText);
            }
            
         }
        
        public void SaveData(object _DataList) 
         { 
            using (StreamWriter writer = File.CreateText(_filePath))
            {
                string output = JsonConvert.SerializeObject(_DataList);
                writer.WriteLine(output);
            }
         }

        
    }
}
