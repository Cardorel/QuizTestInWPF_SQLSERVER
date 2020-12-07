using Prism.Commands;
using Prism.Mvvm;
using ProjectKoursova.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ProjectKoursova.ViewModels
{
    class AdminAddQuestionViewModel : BindableBase
    {
        private int questionId;
        private int subjectId;
        private string question;
        private byte[] image = null;
        private string firstAnswer;
        private string secondAnswer;
        private string thirdAnswer;
        private string fourthAnswer;
        private string correctAnswer;
        private string filename = "Upload an image";
        private string filter;
        private Question selectedItem;
        private ICommand saveCommand;
        private ICommand addCommand;
        private ICommand uploadImage;
        private ICommand deleteCommand;
        private ICommand editCommand;

        public ObservableCollection<Subject> Subjects
        {
            get
            {
                using (var db = new KoursovaEntities2())
                {
                    return new ObservableCollection<Subject>(db.Subjects);
                }
            }
        }
        public ObservableCollection<Question> Questions
        {
            get
            {
                using (var db = new KoursovaEntities2())
                {
                    //check if a user doesnt tape anything
                    if (!string.IsNullOrEmpty(filter))
                    {
                        //get the collection of the filter in good
                        var f = from p in db.Questions where p.question1.Contains(filter) select p;
                        return new ObservableCollection<Question>(f);  //Return new collection

                    }

                    return new ObservableCollection<Question>(db.Questions);  //collection in database
                }
            }
        }

        public Question SelectedItem
        {
            get => selectedItem;
            set => SetProperty(ref selectedItem, value);
        }

        public string Filter
        {
            get => filter;
            set
            {
                if (SetProperty(ref filter, value))
                {
                    RaisePropertyChanged(nameof(Questions));
                }
            }
        }
        public int QuestionId { get => questionId; set => SetProperty(ref questionId, value); }
        public int SubjectId { get => subjectId; set => SetProperty(ref subjectId, value); }
        public string Question { get => question; set => SetProperty(ref question, value); }
        public byte[] Image { get => image; set => SetProperty(ref image, value); }
        public string Filename { get => filename; set => SetProperty(ref filename, value); }
        public string FirstAnswer { get => firstAnswer; set => SetProperty(ref firstAnswer, value); }
        public string SecondAnswer { get => secondAnswer; set => SetProperty(ref secondAnswer, value); }
        public string ThirdAnswer { get => thirdAnswer; set => SetProperty(ref thirdAnswer, value); }
        public string FourthAnswer { get => fourthAnswer; set => SetProperty(ref fourthAnswer, value); }
        public string CorrectAnswer { get => correctAnswer; set => SetProperty(ref correctAnswer, value); }
        public string Username { get; set; }

        public ICommand SaveCommand
        {
            get => saveCommand ?? (saveCommand = new DelegateCommand(() => 
            {
                if (selectedItem != null)
                {

                    var questionAttach = new Question()
                    {
                        questionId = QuestionId,
                        question1 = Question,
                        firstAnswer = FirstAnswer,
                        picture = Image,
                        secondAnswer = SecondAnswer,
                        subjectId = SubjectId,
                        thirdAnswer = ThirdAnswer,
                        fourthAnswer = FourthAnswer,
                        correctAnswer = CorrectAnswer
                    };

                    using (var db = new KoursovaEntities2())
                    {
                        db.Questions.Attach(questionAttach);
                        db.Entry(questionAttach).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        RaisePropertyChanged(nameof(Questions));
                    }
                }
                else
                {
                    MessageBox.Show("Which item do you want to modify?");
                }

                Question = "";
                FirstAnswer = "";
                SecondAnswer = "";
                ThirdAnswer = "";
                Filename = "";
                FourthAnswer = "";
                CorrectAnswer = "";
            }));
        }

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (deleteCommand = new DelegateCommand<RoutedEventArgs>((e) =>
                {
                    if (selectedItem != null)
                    {
                        ///Open the Entity
                        using (var db = new KoursovaEntities2())
                        {
                            //use Attach for repopulate a context that we selected
                            db.Questions.Attach(selectedItem);
                            //For given the Entity about the status
                            db.Entry(selectedItem).State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            RaisePropertyChanged(nameof(Questions));
                        }
                    }
                }));
            }
        }

        public ICommand EditCommand
        {
            get
            {
                return editCommand ?? (editCommand = new DelegateCommand<RoutedEventArgs>((e) => 
                {
                    if (selectedItem != null)
                    {
                        QuestionId = selectedItem.questionId;
                        Question = selectedItem.question1;
                        SubjectId = Convert.ToInt32(selectedItem.subjectId);
                        FirstAnswer = selectedItem.firstAnswer;
                        SecondAnswer = selectedItem.secondAnswer;
                        ThirdAnswer = selectedItem.thirdAnswer;
                        Image = selectedItem.picture;
                        FourthAnswer = selectedItem.fourthAnswer;
                        CorrectAnswer = selectedItem.correctAnswer;
                    }
                }));
            }
        }

        public ICommand UploadImage
        {
            get
            {
                return uploadImage ?? (uploadImage = new DelegateCommand<EventArgs>((e) =>
                {

                    //open dialog
                    OpenFileDialog dlg = new OpenFileDialog();
                    //filter
                    dlg.Filter = "JPEG|*.jpg";
                    dlg.Multiselect = false;
                    dlg.CheckFileExists = true;

                    //open dialog cancel
                    if (dlg.ShowDialog() == DialogResult.Cancel)
                        return;  // return nothing
                    Filename = dlg.FileName; // get file name

                    Image = File.ReadAllBytes(dlg.FileName);
                }));
            }
        }

        public ICommand AddCommand { get => addCommand = (addCommand = new DelegateCommand(() => 
        {
            using (var db = new KoursovaEntities2())
            {
                if (IsFielNotEmpty())
                {
                    if (IsCorrectValue())
                    {
                        db.Questions.Add(new Question()
                        {
                            question1 = Question,
                            subjectId = SubjectId,
                            picture = Image,
                            firstAnswer = FirstAnswer,
                            secondAnswer = SecondAnswer,
                            thirdAnswer = ThirdAnswer,
                            fourthAnswer = FourthAnswer,
                            correctAnswer = CorrectAnswer
                        });
                        db.SaveChanges();
                        RaisePropertyChanged(nameof(Questions));
                        System.Windows.MessageBox.Show("Added all info in DB", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Correct answer doesn't correspond with one of them, please check it!");
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("One of the field is empty");
                }

                Question = "";
                FirstAnswer = "";
                SecondAnswer = "";
                ThirdAnswer = "";
                filename = "";
                FourthAnswer = "";
                CorrectAnswer = "";

            }
        }));}

        private bool IsCorrectValue()
        {
            if (
                FirstAnswer == CorrectAnswer  ||
                SecondAnswer == CorrectAnswer ||
                ThirdAnswer == CorrectAnswer  ||
                FourthAnswer == CorrectAnswer
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFielNotEmpty()
        {
            if (
               !string.IsNullOrWhiteSpace(Question) ||
               !string.IsNullOrWhiteSpace(FirstAnswer) ||
               !string.IsNullOrWhiteSpace(SecondAnswer) ||
               !string.IsNullOrWhiteSpace(ThirdAnswer) ||
               !string.IsNullOrWhiteSpace(FourthAnswer) ||
               !string.IsNullOrWhiteSpace(CorrectAnswer) ||
               Convert.ToInt32(SubjectId) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
