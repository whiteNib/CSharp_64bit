using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox
{
    public partial class Form1 : Form
    {
        private CheckBox[] bitCheckBoxes;
        


        public Form1()
        {
            InitializeComponent();
            InitializeBitCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

         private void InitializeBitCheckBoxes()
        {
            // 비트 수 설정
            int bitCount = 64;

            bitCheckBoxes = new CheckBox[bitCount];

            for (int i = 0; i < bitCount; i++)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                flowLayoutPanelBits.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
               
            }
        }

        private void BitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox가 변경되었을 때 처리할 로직 추가
            UpdateResult();
        }

        private void UpdateResult()
        {
            // 선택된 비트를 이용한 계산 로직 추가
            /** 예: 선택된 비트를 이용하여 2진수 값을 계산하여 표시*/
            int result = 0;
            for (int i = 0; i < bitCheckBoxes.Length; i++)
            {
                if (bitCheckBoxes[i].Checked)
                {
                    result |= (1 << i);
                }
            }

            // 계산 결과를 텍스트 상자에 표시
            textBoxResult.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
