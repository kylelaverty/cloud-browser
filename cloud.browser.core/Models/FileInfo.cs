using System;

namespace cloud.browser.core
{
    /// <summary>
    /// A generic representation of all files in all data sources.
    /// </summary>
    public class FileInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public double SizeInBytes { get; set; }
    }
}
