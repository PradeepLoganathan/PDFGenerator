using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace BestCV.JobSeeker.Models.Evidences
{
    public class Documents : IEnumerable<Document>
    {
        private List<Document> DocumentList { get; set; }

        public Documents()
        {
            DocumentList = new List<Document>();
        }

        public Documents(IEnumerable<Document> Documents)
        {
            DocumentList = new List<Document>();
            DocumentList = Documents.ToList();
        }

        public void AddDocument(Document Document)
        {
            this.DocumentList.Add(Document);
        }

        public IEnumerator<Document> GetEnumerator()
        {
           return this.DocumentList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.DocumentList.GetEnumerator();
        }
    }
}
