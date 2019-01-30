using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PenAndPepper;


namespace PenAndPepper
{
	/*
	 * Author: Christopher Wendholt
	 * 
	 * 
	 * 
	 */
	public partial class dialogUI : Form
	{
		private Spieler player;
		private Encounter encounter;

        public dialogUI(Spieler _player,Encounter _encounter)
        {
			player = _player;
			encounter = _encounter;

			InitializeComponent();
        }

        dialogoptions dialog = new dialogoptions();
        Debug debug = new Debug();
        dialog[] user_choices = new dialog[2];

        /*
         * Neuer Dialog in der Text-Box hinzufügen
         * 
         * Übergabeparameter: 
         *      int _button_id - für Debug-Ausgabe
         *      string _new_dialog - Dialog der hinzugefügt werden soll
         */
        private void new_dialog(string _button_id, string _new_dialog,Spieler player)
        {
            string player_name = player.Name;
            string dialog_text = player_name + ": " + _new_dialog;

            List<string> dialog_history = dialog_textbox.Lines.ToList();
            
            dialog_history.Add(dialog_text);
#if DEBUG

            debug.write(this, MethodBase.GetCurrentMethod(), "Der Benutzer hat Dialogoption "+ _button_id +" ausgewählt!");
            debug.write_line("\t Text: " +
                               _new_dialog);
#endif
            dialog_textbox.Lines = dialog_history.ToArray();
        }

        /*
         * Starte Dialog anhand ob der Gegenüber eine Quest-Geber, ein Händler und usw.
         */
        private void start_new_dialog()
        {
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Startet Dialog!");
#endif
            List<string> dialog_history = dialog_textbox.Lines.ToList();
            dialog_history.Add(dialog.get_Dialogoption_by_Char_Type(encounter.Type));
            dialog_textbox.Lines = dialog_history.ToArray();
        }

        /*
         * Wird ausgeführt wenn das Form geladen wird
         * 
         * Aktion: 1. liest Dialog-Optionen ein und speichert sie in die Listen
         *         2. starte den Dialog
         */
        private void text_algorithmus_Load(object sender, EventArgs e)
        {
            dialog.load_dialog_options();

            user_choices[0] = dialog.get_user_choices();

            do
            {
                user_choices[1] = dialog.get_user_choices();
            }
            while (user_choices[0] == user_choices[1]);


            dialog_option_1.Text = user_choices[0].Dialog_sentence;
            dialog_option_2.Text = user_choices[1].Dialog_sentence;

            start_new_dialog();
        }

        private void dialog_option_1_Click(object sender, EventArgs e)
        {
            string selected_dialog = dialog_option_1.Text;

            new_dialog("1", selected_dialog, player);

            List<string> dialog_history = dialog_textbox.Lines.ToList();
            dialog_history.Add(dialog.get_answer(user_choices[0]));
            dialog_textbox.Lines = dialog_history.ToArray();
        }

        private void dialog_option_2_Click(object sender, EventArgs e)
        {
            string selected_dialog = dialog_option_2.Text;

            new_dialog("2", selected_dialog, player);

            List<string> dialog_history = dialog_textbox.Lines.ToList();
            dialog_history.Add(dialog.get_answer(user_choices[1]));
            dialog_textbox.Lines = dialog_history.ToArray();
        }

        private void dialog_option_cancel_dialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}