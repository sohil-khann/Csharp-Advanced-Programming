namespace PracticeProblems.App;

public class ListManager // Class for managing a list of integers
{
    public void AddElement(List<int> list, int element)// Method to add an element to the list
    {
        list.Add(element);
    }

    public bool RemoveElement(List<int> list, int element)// Method to remove an element from the list
    {
        return list.Remove(element);
    }

    public int GetSize(List<int> list)// Method to get the size of the list
    {
        return list.Count;
    }
}
