using Adapter.Models;
using Adapter.Services.FileWriters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductWriters
{
    public class FileProductWriter : IProductWriter
    {
        private readonly FileWriter _writer;
        private readonly string _filePath;

        public FileProductWriter(FileWriter writer, string filePath)
        {
            _writer = writer;
            _filePath = filePath;
        }

        public async Task WriteProduct(Product product)
        {
            await _writer.Write(_filePath, product.ToString());
        }
    }
}
