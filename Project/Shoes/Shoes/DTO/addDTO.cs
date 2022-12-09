using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class addDTO
    {
        private string noteId;
        private string supplierId;
        private DateTime date;

        public string NoteId { get => noteId; set => noteId = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public DateTime Date { get => date; set => date = value; }

        public addDTO(string noteId, string supplierId, DateTime date)
        {
            NoteId = noteId;
            SupplierId = supplierId;
            Date = date;
        }

        public addDTO(DataRow row)
        {
            NoteId = row["ImportNoteID"].ToString();
            SupplierId = row["SupplierID"].ToString();
            Date = (DateTime)(row["Importdate"]);
        }
    }
}
