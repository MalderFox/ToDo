// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;

namespace ToDoList {

    /// <summary>
    /// Перечисление вариантов цвета записи.
    /// </summary>
    public enum Level {
        Green,
        Yellow,
        Red
    }

    /// <summary>
    /// Обёртка для строк БД.
    /// </summary>
    public class Record {

        public int ID { get; private set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Level Level { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Finish { get; set; }

        public Record() {
        }

        public Record(int id, string title, string text, Level level, DateTime start, DateTime? finish) {
            ID = id;
            Title = title;
            Text = text;
            Level = level;
            Start = start;
            Finish = finish;
        }

    }

}
