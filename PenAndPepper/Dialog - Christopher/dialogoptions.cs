using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;


namespace PenAndPepper
{
    class dialogoptions
    {
		//Objekt fürs debuggen erzeugen
		Debug debug = new Debug();
        string dialog_file_path = "dialog-options\\";

        private dialog Dialog = new dialog();

        //Dialoglisten erzeugen
        List<dialog> greetings = new List<dialog>();
        List<dialog> farewell = new List<dialog>();
        List<dialog> standard_dialog = new List<dialog>();
        List<dialog> answers = new List<dialog>();

        /*
         * Laden der Dialogoptionen
         */
        public void load_dialog_options()
        {
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Begrüßungen werden eingelesen!");
#endif
            greetings = Dialog.get_saved_data(dialog_file_path + "greetings" + ".csv");
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Eingelesender Text:");
            foreach (dialog dl in greetings)
            {
                debug.write_line(dl.Dialog_sentence + " ; " + dl.Assigned_character + " ; " + dl.Answer_type + " ; " + dl.Type);
            }

            debug.write(this, MethodBase.GetCurrentMethod(), "Verabschiedungen werden eingelesen!");
#endif
            farewell = Dialog.get_saved_data(dialog_file_path + "farewell" + ".csv");
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Eingelesender Text:");
            foreach (dialog dl in farewell)
            {
                debug.write_line(dl.Dialog_sentence + " ; " + dl.Assigned_character + " ; " + dl.Answer_type + " ; " + dl.Type);
            }

            debug.write(this, MethodBase.GetCurrentMethod(), "Standard-Dialog wird eingelesen!");
#endif
            standard_dialog = Dialog.get_saved_data(dialog_file_path + "standard_dialog" + ".csv");
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Eingelesender Text:");
            foreach (dialog dl in standard_dialog)
            {
                debug.write_line(dl.Dialog_sentence + " ; " + dl.Assigned_character + " ; " + dl.Answer_type + " ; " + dl.Type);
            }

            debug.write(this, MethodBase.GetCurrentMethod(), "Antworten werden eingelesen!");
#endif
            answers = Dialog.get_saved_data(dialog_file_path + "answers" + ".csv");
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Eingelesender Text:");
            foreach (dialog dl in answers)
            {
                debug.write_line(dl.Dialog_sentence + " ; " + dl.Assigned_character + " ; " + dl.Answer_type + " ; " + dl.Type);
            }
#endif
        }

        /*
         * Rückgabe der Dialogoptionen anhand des Berufes
         * 
         * Übergabeparameter String: Typ des Characters; String Pfad
         * 
         * Rückgabeparameter List<string>: Dialogoptionen
         */
        public string get_Dialogoption_by_Char_Type(string character_Type)
        {
            List<dialog> d_o = greetings;
            List<dialog> filtered_dialog = new List<dialog>();

            for (int i = 0; i < d_o.Count; i++)
            {
                if (d_o[i].Assigned_character == character_Type)
                {
                    filtered_dialog.Add(d_o[i]);
                }
            }
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Es wurden " + filtered_dialog.Count() + " Datensätze gefiltert");
#endif
            if (filtered_dialog.Count != 0)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, filtered_dialog.Count());

                return filtered_dialog[randomNumber].Dialog_sentence;
            }
            else
            {
                return null;
            }
        }

        public dialog get_user_choices()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, standard_dialog.Count());

            return standard_dialog[randomNumber];
        }

        /*
         * Antwort für Benutzer eingabe Ausgeben
         */
        public string get_answer(dialog _dialog)
        {
            string answer = null;
            List<dialog> possible_answers = new List<dialog>();
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Antwort wird anhand des gewählten Dialog ausgewählt!");
#endif
            if (_dialog.Type == "question")
            {
#if DEBUG
                debug.write(this, MethodBase.GetCurrentMethod(), "Der gewählte Dialog war eine Frage!");
#endif
                if (_dialog.Answer_type == "item")
                {
#if DEBUG
                    debug.write(this, MethodBase.GetCurrentMethod(), "Die Antwort wird vom Typ \"Item\" sein!");
#endif
                    for (int i = 0; i < answers.Count(); i++)
                    {
                        if (answers[i].Answer_type == "item")
                        {
                            possible_answers.Add(answers[i]);
                            //get_item_from_inventory();

                            Random random = new Random();
                            int randomNumber = random.Next(0, possible_answers.Count);

                            answer = possible_answers[randomNumber].Dialog_sentence;
                        }
                    }
                }
                else if (_dialog.Answer_type == "feeling")
                {
#if DEBUG
                    debug.write(this, MethodBase.GetCurrentMethod(), "Die Antwort wird vom Typ \"felling\" sein!");
#endif
                    for (int i = 0; i < answers.Count(); i++)
                    {
                        if (answers[i].Answer_type == "feeling")
                        {
                            possible_answers.Add(answers[i]);

                            Random random = new Random();
                            int randomNumber = random.Next(0, possible_answers.Count);

                            answer = possible_answers[randomNumber].Dialog_sentence;
                        }
                    }
                }
                else if (_dialog.Answer_type == "quest")
                {
#if DEBUG
                    debug.write(this, MethodBase.GetCurrentMethod(), "Die Antwort wird vom Typ \"quest\" sein!");
#endif
                    for (int i = 0; i < answers.Count(); i++)
                    {
                        if (answers[i].Answer_type == "quest")
                        {
                            possible_answers.Add(answers[i]);
                            Random random = new Random();
                            int randomNumber = random.Next(0,possible_answers.Count);

                            answer = possible_answers[randomNumber].Dialog_sentence;
                        }
                    }
                }
            }
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Die Antwort auf den ausgewählten Dialog ist:" + answer);
#endif 
            return answer;
        }
    }
}
