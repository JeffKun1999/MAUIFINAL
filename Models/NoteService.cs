﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJSCJR_TacoslaEnredadaInterfaz.Models
{
    public class NoteService
    {
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public static List<Note> LoadNotes()
        {
            if (!File.Exists(filePath))
            {
                return new List<Note>();
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Note>>(json);
        }

        public static void SaveNotes(List<Note> notes)
        {
            var json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(filePath, json);
        }
        public static int GetNextIDRegistro()
        {
            var notes = LoadNotes();
            return notes.Any() ? notes.Max(n => n.IDRegistro) + 1 : 1;
        }
    }
}
