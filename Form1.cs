using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyCharacterStory
{
    public partial class Form1 : Form
    {
        private FortuneData fortuneData = new FortuneData();
        private string selectedFortuneType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectionPanel.Visible = false;
        }

        private void myCharacterStory정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fortune_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                selectedFortuneType = button.Text;
            }
            else if (sender is PictureBox pictureBox)
            {
                selectedFortuneType = pictureBox.Tag?.ToString();
            }

            if (string.IsNullOrEmpty(selectedFortuneType))
            {
                MessageBox.Show("올바른 운세 버튼을 선택해주세요.");
                return;
            }

            ShowFortuneSelectionUI();
        }

        private void ShowFortuneSelectionUI()
        {
            mainPanel.Visible = false;
            selectionPanel.Visible = true;

            faceCheckedListBox.Items.Clear();
            clothesCheckedListBox.Items.Clear();
            accCheckedListBox.Items.Clear();

            FortuneData.CategoryItems itemsToLoad = GetFortuneItems(selectedFortuneType);

            foreach (var item in itemsToLoad.Face.Keys)
            {
                faceCheckedListBox.Items.Add(item);
            }

            foreach (var item in itemsToLoad.Clothing.Keys)
            {
                clothesCheckedListBox.Items.Add(item);
            }

            foreach (var item in itemsToLoad.Accessory.Keys)
            {
                accCheckedListBox.Items.Add(item);
            }
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text;
            FortuneData.CategoryItems itemsData = GetFortuneItems(selectedFortuneType);
            string result = GenerateFortuneResult(userName, selectedFortuneType, itemsData);
            MessageBox.Show(result);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectionPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private string GenerateFortuneResult(string name, string fortuneType, FortuneData.CategoryItems itemsData)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "이름을 입력해주세요.";
            }

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{name}(이)의 {fortuneType}은 다음과 같습니다.");
            resultBuilder.AppendLine(" ");

            int checkedCount = faceCheckedListBox.CheckedItems.Count + clothesCheckedListBox.CheckedItems.Count + accCheckedListBox.CheckedItems.Count;
            if (checkedCount == 0)
            {
                resultBuilder.AppendLine("선택된 아이템이 없습니다. 아이템을 선택하고 다시 시도해주세요.");
                return resultBuilder.ToString();
            }

            foreach (string checkedItem in faceCheckedListBox.CheckedItems)
            {
                resultBuilder.AppendLine($"{checkedItem}: {itemsData.Face[checkedItem]}");
            }

            foreach (string checkedItem in clothesCheckedListBox.CheckedItems)
            {
                resultBuilder.AppendLine($"{checkedItem}: {itemsData.Clothing[checkedItem]}");
            }

            foreach (string checkedItem in accCheckedListBox.CheckedItems)
            {
                resultBuilder.AppendLine($"{checkedItem}: {itemsData.Accessory[checkedItem]}");
            }

            return resultBuilder.ToString();
        }

        private FortuneData.CategoryItems GetFortuneItems(string fortuneType)
        {
            if (fortuneData.AllFortuneItems.ContainsKey(fortuneType))
            {
                return fortuneData.AllFortuneItems[fortuneType];
            }
            return new FortuneData.CategoryItems();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text;
            FortuneData.CategoryItems itemsData = GetFortuneItems(selectedFortuneType);
            string result = GenerateFortuneResult(userName, selectedFortuneType, itemsData);
            MessageBox.Show(result);
        }
    }

    public class FortuneData
    {
        public class CategoryItems
        {
            public Dictionary<string, string> Face = new Dictionary<string, string>();
            public Dictionary<string, string> Clothing = new Dictionary<string, string>();
            public Dictionary<string, string> Accessory = new Dictionary<string, string>();
        }

        public Dictionary<string, CategoryItems> AllFortuneItems = new Dictionary<string, CategoryItems>();

        public FortuneData()
        {
            CategoryItems schoolItems = new CategoryItems();
            schoolItems.Face.Add("얇은 금테 안경", "지적이고 집중하는 이미지를 줍니다. 머리를 맑게 하고, 학업에 대한 진지한 태도를 보여줍니다.");
            schoolItems.Face.Add("일자형 눈썹", "차분하고 단정한 인상을 주어 공부에 쉽게 산만해지지 않는 끈기를 나타냅니다.");
            schoolItems.Face.Add("넓은 이마", "생각의 폭이 넓고 총명함을 상징합니다. 새로운 지식을 받아들이는 데 유리하다고 여겨집니다.");
            schoolItems.Clothing.Add("셔츠", "깔끔하고 단정한 복장은 정신을 바르게 하고 학습에 대한 준비가 되어 있음을 보여줍니다.");
            schoolItems.Clothing.Add("니트 조끼", "안정감 있고 차분한 느낌을 주어 마음을 가라앉히고 오랫동안 집중하는 데 도움을 줍니다.");
            schoolItems.Clothing.Add("블레이저", "권위 있고 신뢰감을 주는 복장으로, 학습 능력에 대한 자신감을 높여줍니다.");
            schoolItems.Accessory.Add("손목시계", "시간을 소중히 여기고 효율적으로 관리하는 습관을 상징하여 계획적인 학습 태도를 갖게 합니다.");
            schoolItems.Accessory.Add("만년필", "신중하고 깊이 있는 사고를 하는 사람의 상징입니다. 지혜를 얻는 데 좋은 기운을 가져다줍니다.");
            schoolItems.Accessory.Add("책 모양 키링", "항상 지식에 대한 열정이 있음을 보여줍니다. 꾸준한 배움의 길을 열어줍니다.");
            AllFortuneItems.Add("학업운", schoolItems);

            CategoryItems moneyItems = new CategoryItems();
            moneyItems.Face.Add("도톰한 귓불", "복이 많고 재물이 따르는 관상으로 알려져 있습니다. 돈을 모으는 데 도움이 됩니다.");
            moneyItems.Face.Add("복스러운 볼", "넉넉하고 풍요로운 인상을 주어 주변에서 재물을 끌어오는 기운을 얻게 됩니다.");
            moneyItems.Face.Add("각진 턱", "강한 의지와 끈기를 상징합니다. 사업을 성공시키고 재물을 지키는 힘이 됩니다.");
            moneyItems.Clothing.Add("실크 셔츠", "고급스럽고 윤기 있는 소재는 재물이 끊임없이 들어오는 통로를 열어줍니다.");
            moneyItems.Clothing.Add("롱 코트", "품위 있는 인상을 주어 큰 재물을 다룰 수 있는 그릇이 됨을 나타냅니다.");
            moneyItems.Clothing.Add("황금색 의상", "재물을 상징하는 색으로, 부와 번영의 기운을 직접적으로 끌어당깁니다.");
            moneyItems.Accessory.Add("금목걸이", "재물을 상징하는 금을 몸에 지녀 재물운을 직접적으로 끌어당깁니다.");
            moneyItems.Accessory.Add("동전 모양 귀걸이", "돈이 끊임없이 모여들고 행운이 굴러들어오는 것을 상징합니다.");
            moneyItems.Accessory.Add("가죽 지갑", "재물을 담는 그릇입니다. 고급스러운 가죽 지갑은 들어온 돈이 밖으로 새지 않고 잘 모이게 해줍니다.");
            AllFortuneItems.Add("재물운", moneyItems);

            CategoryItems healthyItems = new CategoryItems();
            healthyItems.Face.Add("홍조 띤 볼", "혈색이 좋고 생기가 넘치는 모습을 상징합니다. 몸속 기운이 순환하고 있음을 보여줍니다.");
            healthyItems.Face.Add("깨끗한 피부", "내면이 건강하고 몸에 독소가 없음을 나타냅니다. 맑고 깨끗한 기운을 가져옵니다.");
            healthyItems.Face.Add("붉은 입술", "건강한 활력이 넘치는 사람의 상징입니다. 아프지 않고 활기찬 생활을 할 수 있도록 돕습니다.");
            healthyItems.Clothing.Add("트레이닝복 세트", "몸을 편하게 만들어 활동성을 높여줍니다. 자연스럽게 몸을 움직여 건강을 관리하게 합니다.");
            healthyItems.Clothing.Add("스포츠 티셔츠", "통풍이 잘되고 가벼운 옷은 몸의 순환을 방해하지 않습니다. 건강한 에너지가 흐르게 합니다.");
            healthyItems.Clothing.Add("후드티", "몸을 따뜻하게 보호해 주어 외부의 나쁜 기운이 몸에 들어오는 것을 막아줍니다.");
            healthyItems.Accessory.Add("스마트워치", "자신의 건강 상태를 꾸준히 체크하게 합니다. 건강에 대한 경각심을 높여줍니다.");
            healthyItems.Accessory.Add("원석 팔찌", "자연의 좋은 기운을 담고 있는 원석은 몸의 균형을 맞추고 심신을 안정시키는 데 도움을 줍니다.");
            healthyItems.Accessory.Add("헤어밴드", "운동 시 땀과 머리를 정리해 주어 집중력을 높이고 건강한 습관을 만드는 데 도움을 줍니다.");
            AllFortuneItems.Add("건강운", healthyItems);

            CategoryItems loveItems = new CategoryItems();
            loveItems.Face.Add("눈웃음", "사랑스럽고 다정한 인상을 주어 상대방에게 호감을 얻는 데 매우 유리합니다.");
            loveItems.Face.Add("처진 눈꼬리", "부드럽고 순한 느낌을 주어 상대방이 편안함을 느끼게 합니다.");
            loveItems.Face.Add("붉은 입술", "매력을 상징하며, 솔직하고 열정적인 사랑을 나타냅니다.");
            loveItems.Clothing.Add("파스텔 톤 니트", "부드러운 소재와 색상은 온화하고 다정한 성격을 상징합니다.");
            loveItems.Clothing.Add("쉬폰 원피스", "여성스럽고 로맨틱한 분위기를 풍겨 이성의 마음을 사로잡는 데 효과적입니다.");
            loveItems.Clothing.Add("하트 패턴 의상", "사랑의 기운을 직접적으로 나타내어 연애운을 끌어당기는 힘을 가집니다.");
            loveItems.Accessory.Add("하트 목걸이", "사랑의 상징인 하트를 몸에 지녀 연애의 행운을 끌어당깁니다.");
            loveItems.Accessory.Add("향수", "은은하고 매력적인 향은 상대방의 기억에 오래 남아 좋은 인상을 남기게 합니다.");
            loveItems.Accessory.Add("꽃 모양 머리핀", "아름다움과 로맨틱한 분위기를 상징하며, 당신의 매력을 한층 더 돋보이게 합니다.");
            AllFortuneItems.Add("연애운", loveItems);
        }
    }
}