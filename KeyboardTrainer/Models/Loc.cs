﻿using System.Collections.Generic;

namespace KeyboardTrainer.ViewModels
{
    /// <summary>
    /// Localization
    /// </summary>
    public class Loc
    {
        Dictionary<string, string> eng_rus = new Dictionary<string, string>();
        public MLanguage Curr_Language;
        public Loc(MLanguage language)
        {
            this.Curr_Language = language;
        }

        public void AddTranslate(string eng, string rus)
        {
            if (eng_rus.TryGetValue(eng, out string v))
            {
                return;
            }
            eng_rus.Add(eng, rus);
        }
        public string Translate(string engOrRus)
        {
            if (Curr_Language == MLanguage.RUSSIAN)//translate to rus
            {
                if (eng_rus.TryGetValue(engOrRus, out string value))
                {
                    return value;
                }
            }
            if (Curr_Language == MLanguage.ENGLISH)//translate to rus find key by value
            {
                foreach (string currValue in eng_rus.Values)
                {
                    if (currValue == engOrRus)
                    {
                        return KeyByValue(eng_rus, currValue);
                    }
                }
            }
            return engOrRus;
        }
        /// <summary>
        /// Get key by value
        /// </summary>
        /// <returns></returns>
        string KeyByValue(Dictionary<string, string> dict, string val)
        {
            string key = null;
            foreach (KeyValuePair<string, string> pair in dict)
            {
                if (pair.Value == val)
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }
    }
}