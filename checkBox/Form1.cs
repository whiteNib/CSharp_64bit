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
        public CheckBox[] bitCheckBoxes;

        public Form1()
        {
            InitializeComponent();
            InitializeBitCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                checkBox.Font = new Font("맑은 고딕", 12,FontStyle.Bold);
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
            long result = 0;
            for (int i = 0; i < bitCheckBoxes.Length; i++)
            {
                if (bitCheckBoxes[i].Checked)
                {
                    long temp = 1;
                    for (int j = 0; j < i; j++)
                    {
                        temp *= 2;
                    }
                    result |= temp;
                }
            }

            // 계산 결과를 텍스트 상자에 표시
            textBoxResult.Text = result.ToString();
        }
                
    }
}
