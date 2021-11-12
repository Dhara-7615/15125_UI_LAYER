using System;
using System.Collections.Generic;

#nullable disable

namespace Finalprojectwebapi.Models
{
    public partial class Medicine
    {
        public int MedicineId { get; set; }
        public string Diesese { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string MedicalStoreName { get; set; }
        public string PackaginingSize { get; set; }
        public int? Price { get; set; }
        public string Imagepath { get; set; }
    }
}
