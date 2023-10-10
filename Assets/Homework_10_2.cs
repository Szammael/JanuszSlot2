using UnityEngine;

 class Homework_10_2 : MonoBehaviour
{
    [SerializeField, Min(1)] int number = 1;
    [SerializeField] int baseNumber = 1;
    [SerializeField, Min(0)] int exponent = 1;

    void Update()
    {
        int cycleCounter = 1;
        int final = number;
        bool primer = Input.GetKeyUp(KeyCode.KeypadEnter);

        if (primer)
        {
            while (cycleCounter < number)
            {
                final = final + cycleCounter;
                cycleCounter++;
            }
            Debug.Log($"{final}");


            cycleCounter = 1;
            int aid = 1;
            final = 1;
            while (cycleCounter <= number)
            {
                final = final + aid;
                aid++;
                aid++;
                cycleCounter++;
            }
            final = final - 1;
            Debug.Log($"{final}");
            final = final / number;
            Debug.Log($"{final}");

            int i = 1, j = 1;
            while (i <= 10)
            {
                while (j <= 10)
                {
                    Debug.Log($"{i} * {j} = {i * j}");
                    j++;
                }
                i++;
                j = 1;
            }

            Debug.Log($"{Mathf.Pow(baseNumber, exponent)}");


            //Eddig ment magamtól, erre a fizz-buzz megoldásra nem is gondoltam...

            for (i = 1; i <= number; i++)
            {

                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                    Debug.Log("FizzBuzz");
                else if (fizz)
                    Debug.Log("Fizz");
                else if (buzz)
                    Debug.Log("Buzz");
                else
                    Debug.Log(i);


            }

        }

    }
}
