using Frameworks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _env;

        public FileUploader(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void MultipleUpload(List<IFormFile> files, string path)
        {
            int numb = 0;
            var Picpath = $"{_env.WebRootPath}//Img//ProductImages//{path}";
            if (!Directory.Exists(Picpath))
                Directory.CreateDirectory(Picpath);
            foreach (var item in files)
            {
               
                var filename = DateTime.Now.ToFileName() + "-" + item.FileName;
                var pathfile = $"{Picpath}//{filename}";

                using (var stream = File.Create(pathfile))
                {
                    item.CopyTo(stream);
                }
                
            }
        }

        public string Upload(IFormFile file, string folder, string path)
        {
         
            if (file == null) return "";

           
            var Picpath = $"{_env.WebRootPath}//Img//{folder}//{path}";
            if (!Directory.Exists(Picpath))
                Directory.CreateDirectory(Picpath);

            var filename = DateTime.Now.ToFileName() +"-"+ file.FileName;
            var pathfile = $"{Picpath}//{filename}";
           
            using (var stream = File.Create(pathfile))
            {
                file.CopyTo(stream);
            }
            return filename;
            
        }
        
    }
}
