import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
/*
 * Create the Student and Priorities classes here.
 */
import java.util.Comparator; 
import java.util.PriorityQueue; 
import java.util.Iterator;


class Student
{   
    private int id;
    private String name;
    private double cgpa;
    public Student (int id, String name, double cgpa)
    {
       this.id = id;
       this.name = name;
       this.cgpa = cgpa;
    }
    public int getID()
    {
        return id;
    }
    public String getName()
    {
        return name;
    }
    public double getCGPA()
    {
        return cgpa;
    }
}
class Priorities
{
    List<Student> getStudents(List<String> events)
    {
        ArrayList<Student> students = new ArrayList<Student>();
        PriorityQueue<Student> queue = new PriorityQueue<Student>(1000, new PrioritiesComparator()); 
        for (String s : events)
        {
            String[] parts = s.split(" ");
            if (parts[0].equals("ENTER"))
            {
                Student student = new Student(Integer.parseInt(parts[3]), parts[1], Double.parseDouble(parts[2]));
                queue.add(student);
             //   System.out.println("Added " + student.getName() + " with GPA " + student.getCGPA());
            }
            else
            {
                Student student = (Student)queue.poll();
              //  System.out.println("Removed " + student.getName());
            }
        }
        
        while (queue.size() != 0)
        {
            students.add(queue.remove());
        }
        return students;
    }
    class PrioritiesComparator implements Comparator<Student>
    {
        @Override
        public int compare(Student s1, Student s2) 
        { 
           if (s1.getCGPA() > s2.getCGPA())
           
              return -1;
           
            else if (s1.getCGPA() < s2.getCGPA())
               return 1;
            else // GPAs are equal so compare names
            {
               if (s1.getName().compareTo(s2.getName()) >= 1)
                  return 1;
                else if (s1.getName().compareTo(s2.getName()) <= -1)
                   return -1;
                else // Names are equal so compare IDs
                {
                   if (s1.getID() > s2.getID())
                      return 1;
                    else 
                       return -1;
                }
            }
        
        } 
    }
}


public class Solution {
    private final static Scanner scan = new Scanner(System.in);
    private final static Priorities priorities = new Priorities();
    
    public static void main(String[] args) {
        int totalEvents = Integer.parseInt(scan.nextLine());    
        List<String> events = new ArrayList<>();
        
        while (totalEvents-- != 0) {
            String event = scan.nextLine();
            events.add(event);
        }
        
        List<Student> students = priorities.getStudents(events);
        
        if (students.isEmpty()) {
            System.out.println("EMPTY");
        } else {
            for (Student st: students) {
                System.out.println(st.getName());
            }
        }
    }
}