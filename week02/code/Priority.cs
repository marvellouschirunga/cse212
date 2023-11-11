/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: Adds item to back of the queue
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("firstItem", 2);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: Removes item with highest priority and write to console
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("secondItem", 5);
        Console.WriteLine("Dequeue Result: " + priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: index was being compared to _queue.Count -1 instead of queue.Count which is the size of the queue

        Console.WriteLine("---------");

        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Removes the highest priority that's closest to front
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("itemOne", 7);
        priorityQueue.Enqueue("itemTwo", 7);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Was not removing the item with the highest priority but only adding it to a variable

        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: Display an error when dequeing an empty queue
        Console.WriteLine("Test 4");
        Console.WriteLine("Dequeue Result: " + priorityQueue.Dequeue());
        Console.WriteLine("Dequeue Result: " + priorityQueue.Dequeue());
        Console.WriteLine("Dequeue Result: " + priorityQueue.Dequeue());
        // Defect(s) Found: 

        Console.WriteLine("---------");
        // Add more Test Cases As Needed Below
    }
}