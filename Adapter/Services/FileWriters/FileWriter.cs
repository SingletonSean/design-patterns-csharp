using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.FileWriters
{
    public class FileWriter
    {
        public async Task Write(string filePath, string content)
        {
            await File.WriteAllTextAsync(filePath, content);
        }
    }
}
