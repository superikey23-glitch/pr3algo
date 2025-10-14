using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ТекстовыйРедактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ===== КНОПКА "ОТКРЫТЬ" =====
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrEmpty(openFileDialog1.FileName))
                return;

            try
            {
                // Читаем файл как UTF-8
                using (var reader = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ===== КНОПКА "СОХРАНИТЬ КАК" =====
        private void сохранитьКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сохраняем файл в UTF-8
                    using (var writer = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(textBox1.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // ===== КНОПКА "ВЫХОД" =====
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== ПРИ ЗАГРУЗКЕ ФОРМЫ =====
        private void Form1_Load(object sender, EventArgs e)
        {
            // Очищаем поле редактирования
            textBox1.Clear();

            // Настраиваем диалоги
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }
    }
}