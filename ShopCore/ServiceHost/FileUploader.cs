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

        public string Upload(IFormFile file,string path)
        {
            if (file == null) return "";


            var Picpath = $"{_env.WebRootPath}//Img//ProductImages//{path}";
            if (!Directory.Exists(Picpath))
                Directory.CreateDirectory(Picpath);

            var pathfile = $"{Picpath}//{file.FileName}";
           
            using (var stream = File.Create(pathfile))
            {
                file.CopyTo(stream);
            }
            return file.FileName;
            
        }
    }
}
