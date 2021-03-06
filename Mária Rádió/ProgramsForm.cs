﻿using System.Windows.Forms;

namespace Maria_Radio
{
    public partial class ProgramsForm : Form
    {
        private static ProgramsForm instance;

        public static ProgramsForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProgramsForm();
                }

                return instance;
            }
        }

        public DataGridView ProgramList
        {
            get { return dataGridView; }
        }

        private ProgramsForm()
        {
            InitializeComponent();
        }
    }
}
