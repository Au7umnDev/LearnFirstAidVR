using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModuleTest_Blood : MonoBehaviour
{
    public int correctAnswers;

    public Toggle Q1_OptionA;
    public Toggle Q1_OptionB;
    public Toggle Q1_OptionC;
    public Toggle Q1_OptionD;

    public Toggle Q2_OptionA;
    public Toggle Q2_OptionB;
    public Toggle Q2_OptionC;
    public Toggle Q2_OptionD;
    public Toggle Q2_OptionE;
    public Toggle Q2_OptionF;

    public Toggle Q3_OptionA;
    public Toggle Q3_OptionB;
    public Toggle Q3_OptionC;
    public Toggle Q3_OptionD;

    public Toggle Q4_OptionA;
    public Toggle Q4_OptionB;
    public Toggle Q4_OptionC;
    public Toggle Q4_OptionD;
    public Toggle Q4_OptionE;
    public Toggle Q4_OptionF;

    public Toggle Q5_OptionA;
    public Toggle Q5_OptionB;
    public Toggle Q5_OptionC;
    public Toggle Q5_OptionD;
    public Toggle Q5_OptionE;
    public Toggle Q5_OptionF;

    public Toggle Q6_OptionA;
    public Toggle Q6_OptionB;
    public Toggle Q6_OptionC;
    public Toggle Q6_OptionD;
    public Toggle Q6_OptionE;
    public Toggle Q6_OptionF;

    public Toggle Q7_OptionA;
    public Toggle Q7_OptionB;
    public Toggle Q7_OptionC;
    public Toggle Q7_OptionD;
    public Toggle Q7_OptionE;

    public Toggle Q8_OptionA;
    public Toggle Q8_OptionB;
    public Toggle Q8_OptionC;
    public Toggle Q8_OptionD;

    public Toggle Q9_OptionA;
    public Toggle Q9_OptionB;
    public Toggle Q9_OptionC;

    public Toggle Q10_OptionA;
    public Toggle Q10_OptionB;
    public Toggle Q10_OptionC;

    public GameObject testCorrect;
    public GameObject testIncorrect;
    public GameObject completedMark;

    public void BeginTest()
    {
        correctAnswers = 0;
    }

    public void EnablePractice_Blood()
    {
        //Поставить внешнюю булевую переменную как true
    }

    public void RunAllTests()
    {
        CheckQuestion_1();
        CheckQuestion_2();
        CheckQuestion_3();
        CheckQuestion_4();
        CheckQuestion_5();
        CheckQuestion_6();
        CheckQuestion_7();
        CheckQuestion_8();
        CheckQuestion_9();
        CheckQuestion_10();

        if(correctAnswers == 10)
        {
            testCorrect.SetActive(true);
            completedMark.SetActive(true);
            EnablePractice_Blood();
        }
        else
        {
            testIncorrect.SetActive(true);
        }
    }

    public void CloseTest()
    {
        Q1_OptionA.isOn = false;
        Q1_OptionB.isOn = false;
        Q1_OptionC.isOn = false;
        Q1_OptionD.isOn = false;

        Q2_OptionA.isOn = false;
        Q2_OptionB.isOn = false;
        Q2_OptionC.isOn = false;
        Q2_OptionD.isOn = false;
        Q2_OptionE.isOn = false;
        Q2_OptionF.isOn = false;

        Q3_OptionA.isOn = false;
        Q3_OptionB.isOn = false;
        Q3_OptionC.isOn = false;
        Q3_OptionD.isOn = false;

        Q4_OptionA.isOn = false;
        Q4_OptionB.isOn = false;
        Q4_OptionC.isOn = false;
        Q4_OptionD.isOn = false;
        Q4_OptionE.isOn = false;
        Q4_OptionF.isOn = false;

        Q5_OptionA.isOn = false;
        Q5_OptionB.isOn = false;
        Q5_OptionC.isOn = false;
        Q5_OptionD.isOn = false;
        Q5_OptionE.isOn = false;
        Q5_OptionF.isOn = false;

        Q6_OptionA.isOn = false;
        Q6_OptionB.isOn = false;
        Q6_OptionC.isOn = false;
        Q6_OptionD.isOn = false;
        Q6_OptionE.isOn = false;
        Q6_OptionF.isOn = false;

        Q7_OptionA.isOn = false;
        Q7_OptionB.isOn = false;
        Q7_OptionC.isOn = false;
        Q7_OptionD.isOn = false;
        Q7_OptionE.isOn = false;

        Q8_OptionA.isOn = false;
        Q8_OptionB.isOn = false;
        Q8_OptionC.isOn = false;
        Q8_OptionD.isOn = false;

        Q9_OptionA.isOn = false;
        Q9_OptionB.isOn = false;
        Q9_OptionC.isOn = false;

        Q10_OptionA.isOn = false;
        Q10_OptionB.isOn = false;
        Q10_OptionC.isOn = false;
    }

    public void CheckQuestion_1()
    {
        if(Q1_OptionA.isOn && Q1_OptionD.isOn && !Q1_OptionB.isOn && !Q1_OptionC.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_2()
    {
        if (Q2_OptionC.isOn && Q2_OptionD.isOn && Q2_OptionE.isOn && Q2_OptionF.isOn && !Q2_OptionA.isOn && !Q2_OptionB.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_3()
    {
        if (Q3_OptionB.isOn && Q3_OptionC.isOn && !Q3_OptionA.isOn && !Q3_OptionD.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_4()
    {
        if (Q4_OptionB.isOn && Q4_OptionD.isOn && Q4_OptionE.isOn && Q4_OptionF.isOn && !Q4_OptionA.isOn && !Q4_OptionC.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_5()
    {
        if (Q5_OptionA.isOn && Q5_OptionB.isOn && Q5_OptionC.isOn && Q5_OptionD.isOn && !Q5_OptionE.isOn && !Q5_OptionF.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_6()
    {
        if (Q6_OptionA.isOn && Q6_OptionC.isOn && Q6_OptionE.isOn && Q6_OptionF.isOn && !Q6_OptionB.isOn && !Q6_OptionD.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_7()
    {
        if (Q7_OptionC.isOn && Q7_OptionD.isOn && !Q7_OptionA.isOn && !Q7_OptionB.isOn && !Q7_OptionE.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_8()
    {
        if (!Q8_OptionA.isOn && !Q8_OptionB.isOn && !Q8_OptionC.isOn && Q8_OptionD.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_9()
    {
        if (Q9_OptionA.isOn && !Q9_OptionB.isOn && !Q9_OptionC.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }
    public void CheckQuestion_10()
    {
        if (!Q10_OptionA.isOn && Q10_OptionB.isOn && !Q10_OptionC.isOn)
        {
            correctAnswers++;
            return;
        }
        else
        {
            return;
        }
    }

}
