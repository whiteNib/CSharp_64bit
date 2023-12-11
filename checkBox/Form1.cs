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
            flowLayoutPanelBits.Dock = DockStyle.Bottom;
            this.MinimumSize = new System.Drawing.Size(450, 600);
            timer1.Start();
            // textBoxResult가 10진수가 입력되는 TextBox인 것으로 가정
            textBoxResult.TextChanged += textBoxResult_TextChanged;
        }

        private void InitializeBitCheckBoxes()
        {
            // 비트 수 설정
            int bitCount = 64;

            bitCheckBoxes = new CheckBox[bitCount];


            for (int i = bitCount - 1; i >= 48; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel7.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
                checkBox.Margin = new Padding(0,0,0,0);
                checkBox.Dock = DockStyle.Left;
                checkBox.FlatAppearance.MouseOverBackColor = Color.Transparent;

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(243,243,243); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 47; i >= 32; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel5.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
                checkBox.Margin = new Padding(0, 0, 0, 0);
                checkBox.Dock = DockStyle.Left;
                checkBox.FlatAppearance.MouseOverBackColor = Color.Transparent;

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 243, 243); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 31; i >= 16; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel3.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
                checkBox.Margin = new Padding(0, 0, 0, 0);
                checkBox.Dock = DockStyle.Left;
                checkBox.FlatAppearance.MouseOverBackColor = Color.Transparent;

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 243, 243); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 15; i >= 0; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel1.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
                checkBox.Margin = new Padding(0, 0, 0, 0);
                checkBox.Dock = DockStyle.Left;
                checkBox.FlatAppearance.MouseOverBackColor = Color.Transparent;

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 243, 243); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }
        }

        private void BitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox가 변경되었을 때 처리할 로직 추가
            UpdateResult();
        }

        // 체크된 체크박스 처리 영역
        private void UpdateResult()
        {
            // 선택된 비트를 이용한 계산 로직 추가
            long result = 0;
            for (int i = 0; i < bitCheckBoxes.Length; i++)
            {
                if (bitCheckBoxes[i].Checked)
                {
                    result |= (1L << i);
                    bitCheckBoxes[i].Text = "1";
                    bitCheckBoxes[i].ForeColor = Color.FromArgb(0,99,153);
                    //long temp = 1;
                    //for (int j = 0; j < i; j++)
                    //{
                    //    temp *= 2;
                    //}
                    //result |= temp;
                }
                else
                {
                    bitCheckBoxes[i].Text = "0";
                    bitCheckBoxes[i].ForeColor = Color.FromArgb(0,0,0);
                }
            }

            // 계산 결과를 텍스트 상자에 표시
            textBoxResult.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(this.Height * 0.05625);
            tableLayoutPanel1.Height = y;
            tableLayoutPanel2.Height = y;
            tableLayoutPanel3.Height = y;
            tableLayoutPanel4.Height = y;
            tableLayoutPanel5.Height = y;
            tableLayoutPanel6.Height = y;
            tableLayoutPanel7.Height = y;
            flowLayoutPanelBits.Height = y;

            if (textBoxResult.Text == "")
            {
                textBoxResult.Text = "0";
            }

            textBoxResult.SelectionStart = textBoxResult.Text.Length;
        }
        long decimalValue = 0;
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            // textBoxResult의 텍스트가 변경되면 체크박스를 업데이트
            if (long.TryParse(textBoxResult.Text, out decimalValue))
            {
                UpdateCheckboxes(decimalValue);
            }
            else
            {
                // 입력된 텍스트가 유효한 10진수가 아닌 경우에 대한 처리
            }
        }
        private void UpdateCheckboxes(long decimalValue)
        {
            // 10진수 값을 기반으로 체크박스 상태를 업데이트
            for (int i = 0; i < bitCheckBoxes.Length; i++)
            {
                long mask = 1L << i;
                bitCheckBoxes[i].Checked = (decimalValue & mask) != 0;
            }
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {
            // 텍스트 박스를 클릭할 때 다른 컨트롤에 포커스를 이동시켜 커서를 가리키지 않도록 함
        }
                
    }
}