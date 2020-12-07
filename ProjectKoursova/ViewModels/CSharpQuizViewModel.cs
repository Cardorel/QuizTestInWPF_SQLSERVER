using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectKoursova.Models;
using System.Windows.Input;
using Prism.Commands;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ProjectKoursova.ViewModels
{
     class CSharpQuizViewModel: BindableBase
    {
        private string currentUsername;
        private string currentUseremail;
        private string question1;
        private string firstAnswer;
        private string secondAnswer;
        private string thirdAnswer;
        private string fourthAnswer;
        private string correctAnswer;
        private byte [] image = null;
        private int next = 1;
        private int score = 0;
        private bool? checkBtn = false;
        private bool?isSecondBtnChecked = false;
        private bool? isThirdBtnChecked = false;
        private bool? isFourthBtnChecked = false;
        private string isBtnVisible = "Visible";
        private string isBtnHidden = "Hidden";
        private string hiddenQuestion = "Hidden";
        private string visibleQuestion = "Visible";
        private string selectedAnswer;
        private List<string> currentUserListInfo = new List<string>();
        private ICommand nextCommand;
        private ICommand submitCommand;
        private ICommand checkedAnswerCommand;
        private Registration reg;
        DispatcherTimer timer;
        private int secondTimer = 0;

        public CSharpQuizViewModel()
        {
            QuestionNext(1);
        }

        [Obsolete]
        public CSharpQuizViewModel(Registration _username)
            : this()
        {
            this.reg = _username;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SecondTimer++;
            RaisePropertyChanged(nameof(SecondTimer));
        }

        public ObservableCollection<Question> Questions
        {
            get
            {
                using (var db = new KoursovaEntities2())
                {
                    return new ObservableCollection<Question>(db.Questions);
                }
            }
        }

        
        public string CurrentUsername 
        { 
            get ; 
            set; 
        }
        public string CurrentUserEmail { get => currentUseremail; set => SetProperty(ref currentUseremail, value); }
        public string FirstAnswer { get => firstAnswer; set => SetProperty(ref firstAnswer , value); }
        public string SecondAnswer { get => secondAnswer; set => SetProperty(ref secondAnswer , value); }
        public string ThirdAnswer { get => thirdAnswer; set => SetProperty(ref thirdAnswer ,  value); }
        public string FourthAnswer { get => fourthAnswer; set => SetProperty(ref fourthAnswer , value); }
        public string CorrectAnswer { get => correctAnswer; set => SetProperty(ref correctAnswer , value); }
        public byte[] Image { get => image; set => SetProperty(ref image , value); }
        public int Next { get => next; set => SetProperty(ref next , value); }
        public int Score { get => score; set => SetProperty(ref score , value); }
        public string Question1 { get => question1; set => SetProperty(ref question1 , value); }
        public string SelectedAnswer { get => selectedAnswer; set => SetProperty(ref selectedAnswer, value); }
        public string IsBtnVisible { get => isBtnVisible; set => SetProperty(ref isBtnVisible , value); }
        public string IsBtnHidden { get => isBtnHidden; set => SetProperty(ref isBtnHidden, value); }
        public string HiddenQuestion { get => hiddenQuestion; set => SetProperty(ref hiddenQuestion , value); }
        public string VisibleQuestion { get => visibleQuestion; set => SetProperty(ref visibleQuestion , value); }
        public int SecondTimer { get => secondTimer; set => secondTimer = value; }
        public bool?IsCheckRadioBtn 
        { 
            get => checkBtn;
            set 
            {
                SetProperty(ref checkBtn, value);
            } 
        }

        public bool? IsSecondBtnChecked
        {
            get => isSecondBtnChecked;
            set
            {
                SetProperty(ref isSecondBtnChecked, value);
            }
        }

        public bool? IsThirdBtnChecked
        {
            get => isThirdBtnChecked;
            set
            {
                SetProperty(ref isThirdBtnChecked, value);
            }
        }

        public bool? IsFourthBtnChecked
        {
            get => isFourthBtnChecked;
            set
            {
                SetProperty(ref isFourthBtnChecked, value);
            }
        }


        public void QuestionContent(IEnumerable<Question> a)
        {
            Question1 = a.FirstOrDefault().question1;
            FirstAnswer = a.FirstOrDefault().firstAnswer;
            SecondAnswer = a.FirstOrDefault().secondAnswer;
            ThirdAnswer = a.FirstOrDefault().thirdAnswer;
            FourthAnswer = a.FirstOrDefault().fourthAnswer;
            CorrectAnswer = a.FirstOrDefault().correctAnswer;
            Image = a.FirstOrDefault().picture;
        }

        public void QuestionNext(int num)
        {
            var s = Questions.Where(e => Convert.ToInt32(e.subjectId) == 1);

            if(s.Count() >= num)
            {
                switch (num)
                {
                    case 1:
                        var a = s.Skip(0).Take(1);
                        QuestionContent(a);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 2:
                        var b = s.Skip(1).Take(1);
                        QuestionContent(b);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 3:
                        var d = s.Skip(2).Take(1);
                        QuestionContent(d);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 4:
                        var e = s.Skip(3).Take(1);
                        QuestionContent(e);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 5:
                        var f = s.Skip(4).Take(1);
                        QuestionContent(f);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 6:
                        var g = s.Skip(5).Take(1);
                        QuestionContent(g);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 7:
                        var h = s.Skip(6).Take(1);
                        QuestionContent(h);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 8:
                        var i = s.Skip(7).Take(1);
                        QuestionContent(i);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 9:
                        var j = s.Skip(8).Take(1);
                        QuestionContent(j);
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    case 10:
                        var k = s.Skip(9).Take(1);
                        QuestionContent(k);
                        currentUserListInfo.Add(SelectedAnswer);
                        IsBtnVisible = "Hidden";
                        IsBtnHidden = "Visible";
                        break;
                    case 11:
                        currentUserListInfo.Add(SelectedAnswer);
                        break;
                    default:
                        break;
                }
            }
        }

        public ICommand NextCommand
        {
            get
            {
                return nextCommand ?? (nextCommand = new DelegateCommand(() =>
                {
                    if (!string.IsNullOrEmpty(selectedAnswer))
                    {
                        IsCheckRadioBtn = false;
                        IsSecondBtnChecked = false;
                        IsThirdBtnChecked = false;
                        IsFourthBtnChecked = false;
                        SubmitCorrectAnswer();
                        Next += 1;
                        QuestionNext(Next);
                        RaisePropertyChanged(nameof(Score));
                    }
                    else
                    {
                        MessageBox.Show("Please select answer!");
                    }
                }));
            }
        }

        public void SubmitCorrectAnswer()
        {
            if(CorrectAnswer == SelectedAnswer)
            {
                Score += 1;
            }
        }

        public ICommand SubmitCommand
        { 
            get => submitCommand ?? (submitCommand = new DelegateCommand(() => 
            {
                HiddenQuestion = "Visible";
                VisibleQuestion = "Hidden";
                SubmitCorrectAnswer();
                Next += 1;
                QuestionNext(Next);
                RaisePropertyChanged(nameof(Score));
                var u = reg.username;
                timer.Stop();

                using (var db = new KoursovaEntities2())
                {
                    if (currentUserListInfo.Count() != 0)
                    {
                        db.UserAnswers.Add(new UserAnswer()
                        {
                            email = reg.email,
                            subject = "C#",
                            answer1 = currentUserListInfo[1],
                            answer2 = currentUserListInfo[2],
                            answer3 = currentUserListInfo[3],
                            answer4 = currentUserListInfo[4],
                            answer5 = currentUserListInfo[5],
                            answer6 = currentUserListInfo[6],
                            answer7 = currentUserListInfo[7],
                            answer8 = currentUserListInfo[8],
                            answer9 = currentUserListInfo[9],
                            username = u,
                            totalScore = Score,
                            answer10 = currentUserListInfo[10],

                        }); ;

                        db.SaveChanges();
                        RaisePropertyChanged(nameof(Questions));
                    }
                }
            }));
        }

        public ICommand CheckedAnswerCommand { get => checkedAnswerCommand ?? (checkedAnswerCommand = new DelegateCommand<Object>((p) => 
        {
            var h = (TextBlock)p;
            SelectedAnswer = h.Text;
        })); }
    }
}
