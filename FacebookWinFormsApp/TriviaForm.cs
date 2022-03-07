using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class TriviaForm : FormFeature
    {
        private readonly TriviaFeatureLogic r_TriviaFeatureLogic;

        public TriviaForm(User i_User)
        {
            InitializeComponent();
            r_TriviaFeatureLogic = new TriviaFeatureLogic();
            fetchTriviaInfo(i_User);
        }

        private void fetchTriviaInfo(User i_User)
        {
            List<User> filteredFriends = new List<User>(i_User.Friends);
            User randomFriend = r_TriviaFeatureLogic.GetRandomFriend(filteredFriends);

            if (randomFriend != null)
            {
                labelError.Visible = false;
                pictureBoxTriviaFriend.Image = randomFriend.ImageLarge;
                fillTriviaAnswers(randomFriend);
                initTriviaRadioButtons();
            }
            else
            {
                hideTriviaComponents();
            }
        }

        private void hideTriviaComponents()
        {
            groupBoxTriviaQ1.Visible = false;
            groupBoxTriviaQ2.Visible = false;
            groupBoxTriviaQ3.Visible = false;
            groupBoxTriviaQ4.Visible = false;
            buttonSubmit.Visible = false;
            labelScore.Visible = false;
            labelTitleScore.Visible = false;
            labelError.Visible = true;
            labelError.Text = @"You have no friends using this app.
Trivia is disable!";
        }

        private void fillTriviaAnswers(User i_RandomFriend)
        {
            List<string> Q1Answers = r_TriviaFeatureLogic.GetQ1Answers();
            List<string> Q2Answers = r_TriviaFeatureLogic.GetQ2Answers();
            List<string> Q3Answers = r_TriviaFeatureLogic.GetQ3Answers();
            List<string> Q4Answers = r_TriviaFeatureLogic.GetQ4Answers();

            fillQuestionAnswers(Q1Answers, groupBoxTriviaQ1);
            fillQuestionAnswers(Q2Answers, groupBoxTriviaQ2);
            fillQuestionAnswers(Q3Answers, groupBoxTriviaQ3);
            fillQuestionAnswers(Q4Answers, groupBoxTriviaQ4);
        }

        private void fillQuestionAnswers(List<string> i_Answers, GroupBox i_GroupBoxTrivia)
        {
            if (i_Answers != null && i_Answers.Count == 4)
            {
                int index = 0;
                foreach (RadioButton radioButton in i_GroupBoxTrivia.Controls.OfType<RadioButton>())
                {
                    radioButton.Text = i_Answers[index++];
                }
            }
            else
            {
                i_GroupBoxTrivia.Enabled = false;
            }
        }

        private void submitTriviaAnswers()
        {
            string emailAnswer, zodiacSignAnswer, locationAnswer, ageFriendAnswer;
            int enabledTriviaQuestions = getEnabledTriviaQuestionsNumber();

            emailAnswer = groupBoxTriviaQ1.Enabled
                              ? groupBoxTriviaQ1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text
                              : null;
            zodiacSignAnswer = groupBoxTriviaQ2.Enabled
                                   ? groupBoxTriviaQ2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text
                                   : null;
            locationAnswer = groupBoxTriviaQ3.Enabled
                                 ? groupBoxTriviaQ3.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text
                                 : null;
            ageFriendAnswer = groupBoxTriviaQ4.Enabled
                                  ? groupBoxTriviaQ4.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text
                                  : null;

            int rightAnswers = r_TriviaFeatureLogic.AnalyzeAnswers(
                emailAnswer,
                zodiacSignAnswer,
                locationAnswer,
                ageFriendAnswer);
            labelScore.Text = $"{rightAnswers} \\ {enabledTriviaQuestions}";

            labelScore.Visible = true;
        }

        private void randomizeNewTriviaFriend()
        {
            List<User> filteredFriends = new List<User>(User.Friends);
            User friend = r_TriviaFeatureLogic.GetRandomFriend(filteredFriends);

            pictureBoxTriviaFriend.Image = friend.ImageLarge;
            clearTriviaRadioButtons();
            enableTriviaAnswerGroups();
            fillTriviaAnswers(friend);
            buttonSubmit.Enabled = false;
            labelScore.Visible = false;
        }

        private void enableTriviaAnswerGroups()
        {
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                groupBox.Enabled = true;
            }
        }

        private void clearTriviaRadioButtons()
        {
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = false;
                }
            }
        }

        private int getEnabledTriviaQuestionsNumber()
        {
            int counter = 0;
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                if (groupBox.Enabled)
                {
                    ++counter;
                }
            }

            return counter;
        }

        private void initTriviaRadioButtons()
        {
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    radioButton.CheckedChanged += radioButtonTriviaAnswer_CheckedChanged;
                }
            }
        }

        private void radioButtonTriviaAnswer_CheckedChanged(object sender, EventArgs e)
        {
            checkSubmitButtonDisability();
        }

        private void checkSubmitButtonDisability()
        {
            bool enableSubmitButton = true;

            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                if (groupBox.Enabled && groupBox.Controls.OfType<RadioButton>().Where(radioButton => radioButton.Checked)
                        .ToList().Count == 0)
                {
                    enableSubmitButton = false;
                    break;
                }
            }

            if (enableSubmitButton)
            {
                buttonSubmit.Enabled = true;
            }
        }

        private void groupBoxTriviaQ1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxTriviaQ2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxTriviaQ3_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxTriviaQ4_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBoxTriviaFriend_Click(object sender, EventArgs e)
        {
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            submitTriviaAnswers();
        }

        private void labelTitleScore_Click(object sender, EventArgs e)
        {
        }

        private void buttonTriviaRandomFriend_Click(object sender, EventArgs e)
        {
             randomizeNewTriviaFriend();
        }
    }
}
