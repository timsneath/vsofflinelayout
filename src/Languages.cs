using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsofflinelayout
{
    public class Language
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Language(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }

    public class Languages : ObservableCollection<Language>
    {
        public Languages() : base()
        {
            // TODO: Read these from the manifest so they are always updated
            Add(new Language("cs-CZ", "Czech"));
            Add(new Language("de-DE", "German"));
            Add(new Language("en-US", "English"));
            Add(new Language("es-ES", "Spanish"));
            Add(new Language("fr-FR", "French"));
            Add(new Language("it-IT", "Italian"));
            Add(new Language("ja-JP", "Japanese"));
            Add(new Language("ko-KR", "Korean"));
            Add(new Language("pl-PL", "Polish"));
            Add(new Language("pt-BR", "Portuguese - Brazil"));
            Add(new Language("ru-RU", "Russian"));
            Add(new Language("tr-TR", "Turkish"));
            Add(new Language("zh-CN", "Chinese - Simplified"));
            Add(new Language("zh-TW", "Chinese - Traditional"));
        }

    }
}
