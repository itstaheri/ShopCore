using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string path);
        void MultipleUpload(List<IFormFile> files,string path);
    }
}
