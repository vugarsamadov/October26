using October26.Model;

namespace CustomCollection.List;

public class IntList
{
    private Student[] array = new Student[0];

    public void Add(int number)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = number;
    }

    public int BinarySearch(int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (target == array[mid])
                return mid;
            else if (target < array[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }

        return -1;
    }

    public void InsertionSort()
    {
        for (int i = 1; i < array.Length; i++) 
        {
            int key = array[i];
            int j = i-1;
            while (j >= 0 && key < array[j])
            {
                array[j+1] = array[j];
                array[j] = key;
                j--;
            }
        }
    }

    public int JumpSearch(int target)
    {
        int n = array.Length;
        int jump = (int)Math.Sqrt(n);
        int prev = 0;
        int cur = jump;

        while (cur < n && target > array[cur])
        {
            prev = cur;
            cur += jump;
        }
        while (prev <= cur)
        {
            if (target == array[prev])
                return prev;
            prev++;
        }
        return -1;
    }

    public void SelectionSort()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minElementIndx = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minElementIndx])
                {
                    minElementIndx = j;
                }
            }
            if (minElementIndx == i) continue;
            array[i] = array[minElementIndx] + array[i];
            array[minElementIndx] = array[i] - array[minElementIndx];
            array[i] = array[i] - array[minElementIndx];
        }
    }

    public void Add(int[] numbers)
    {
        int OldArrayLength = array.Length;
        Array.Resize(ref array, OldArrayLength + numbers.Length);
        for (int i = OldArrayLength; i < array.Length; i++)
        {
               array[i] = numbers[i - OldArrayLength];
        }
    }

    public int Get(int index)
    {
        if(index<0)
        {
            Console.WriteLine("Invalid index!");
            return -1;
        }
        return array[index];
    }

    public int[] GetAll()
    {
        return array;
    }


    public void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }


}
