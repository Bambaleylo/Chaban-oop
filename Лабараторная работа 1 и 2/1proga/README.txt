�������:

 ������� ����� �������� ��������� ����������� ������� � ����.

(1)���������� ����� Person, ������� �����  
�	�������� ���� ���� string, � ������� �������� ���; 
�	�������� ���� ���� string, � ������� �������� �������; 
�	�������� ���� ���� System.DateTime ��� ���� ��������. 
 
(2)� ������ Person ���������� ������������: 
�	�����������  c ����� ����������� ���� string, string, DateTime ��� ������������� 
���� ����� ������;  
�	�����������  ���  ����������,  ����������������  ���  ����  ������  ���������� 
���������� �� ���������. 
 
(3)� ������ Person ���������� �������� c �������� get � set: 
�	�������� ���� string ��� ������� � ���� � ������;  
�	�������� ���� string ��� ������� � ���� � ��������; 
�	�������� ���� DateTime ��� ������� � ���� � ����� ��������; 
�	�������� ���� int c �������� get � set ��� ��������� ����������(get) � ��������� 
(set)  ����  ��������  �  ��������  ����  ����  DateTime,  �  �������  ��������  ���� 
��������. 
 
(4)� ������ Person ���������� 
�	�������������(override)  ������  ������������  ������  string  ToString()  ��� 
������������ ������ �� ���������� ���� ����� ������; 
�	����������� ����� string ToShortString(), ������� ���������� ������, ���������� 
������ ��� � �������. 
 
(5)�  ������  Person  �  �  �������,  ������������� ��������� � ���������, ����  
�	�������������� (override) ����������� ����� bool Equals (object obj); 
�	���������� ��������  ==  �  != ; 
�	�������������� ����������� ����� int GetHashCode();
(6)���������� ���������  
interface IDateAndCopy 
{  
object DeepCopy(); 
DateTime Date { get; set; } 
}
(7)� ������ Person �������������  
�	�������������� ����� virtial bool Equals (object obj) � ���������� �������� == � != 
���,  �����  ���������  ��������  ����  Person  ������������  ���  ����������  ���� 
������ ��������, � �� ������ �� ������� Person;  
�	�������������� ����������� ����� int GetHashCode(); 
�	���������� ����������� ����� object DeepCopy(); 
�	����������� ��������� IDateAndCopy. 


(8)����������  ���  Education  -  ������������(enum)  ��  ����������: 
�	Specialist 
�	�achelor 
�	SecondEducation. 
 
(9)����������  �����   Exam,  �������  �����  ���  ��������  ��������������� ��������, 
��������� ��� ������ � ������: 
�	�������� ���� string, � ������� �������� �������� ��������;  
�	�������� ���� int, � ������� �������� ������; 
�	�������� ���� System.DateTime ��� ���� ��������. 
(10)� ������ Exam ����������: 
�	�����������  �  �����������  ����  string,  int  �  DateTime  ���  �������������  ���� 
������� ������;  
�	����������� ��� ����������, ���������������� ��� �������� ������ ���������� 
���������� �� ���������; 
�	�������������(override)  ������  ������������  ������  string  ToString()  ��� 
������������ ������ �� ���������� ���� ������� ������;  
�	����������� ��������� IDateAndCopy. 
(11)����������  �����  Test,  �������  �����  ���  ��������  ��������������� ��������, 
��������� ��� ������ � ������: 
�	�������� ���� string, � ������� �������� �������� ��������;  
�	�������� ���� bool ��� ���������� � ���, ���� ����� ��� ���. 
(12)� ������ Test ����������: 
�	����������� c ����������� ���� string � bool ��� ������������� ������� ������;  
�	�����������  ��� ����������, ���������������� ��� �������� ������ ���������� 
���������� �� ���������; 
�	�������������(override)  ������  ������������  ������  string  ToString()  ��� 
������������ ������ �� ���������� ���� ������� ������;  
�	����������� ��������� IDateAndCopy. 
(13)���������� ����� Student ��� ����������� �� ������ Person.  
����� Student ����� ��������� ����: 
�	�������� ���� ���� Education ��� ���������� � ����� ��������; 
�	�������� ���� ���� int ��� ������ ������; 
�	�������� ���� ���� System.Collections.ArrayList, � ������� �������� ������ ������� 
(������� ���� Test); 
�	�������� ���� ���� Exam[] ��� ���������� �� ���������, ������� ���� �������. 
(14)� ������ Student ���������� ������������: 
�	�����������  c  �����������    ����  Person,  Education,  int  ���  ������������� 
��������������� ����� ������; 
�	����������� ��� ���������� ��� ������������� �� ���������; 
(15)� ������ Student ���������� �������� c �������� get � set: 
�	�������� ���� Person; �����  get �������� ���������� ������ ���� Person,  ������ 
�������� ��������� � ������� ���������� �������� ������, ����� set ����������� 
�������� ����� �� ���������� �������� ������;  
�	�������� ���� System.Collections.ArrayList  � �������� get � set ��� ������� � ���� 
�� ������� �������;  
�	�������� ���� Exam[] ��� ������� � ���� �� ������� ���������. 
(16)� ������ Student ����������  
�	�������� ���� double (������ � ������� get), � ������� ����������� ������� ���� 
��� ������� �������� ������ � ������ ������� ���������;  �����  void  AddExams  (  params  Exam[]  )    ���  ����������  ���������  �  ������ ���������;  
�	����� void AddTests ( params Test[] )  ��� ���������� ��������� � ������ ������; 
�	�������������  ������  ������������  ������  string  ToString()  ���  ������������ 
������ �� ���������� ���� ����� ������, ������� ������ ������� � ���������; 
�	�����������  �����  string  ToShortString(),  �������  ���������  ������  �� 
����������  ����  �����  ������  ���  ������  �������  �  ���������,  ��  ��  ��������� �������� �����. 
(17)������������� � ������ Student  
�	���������� ������������� ������ ������������ ������ object DeepCopy(); 
�	����������� ��������� IDateAndCopy; 
�	���������� �������� ���� int �  ��������  get  �  set ��� �������  � ���� � ������� 
������.  �  ������  set �������  ����������,  ����  �������������  ��������  ������ 
���  �����  100  ���  ������  599.  ���  ��������  �������-����������  ������������ 
���� �� ������������ � ���������� CLR  �������-����������,  ���������������� 
������-����������  �  �������  ������������  �  ����������  ����  string,  � 
��������� �������� ���������� � ���������� �������� ��� �������� ��������. 
(18)� ��������� ������ Main() 
1.  �������  ����  ������  ����  Student,  �������������  ������  �  ��������� ��� � 
������� ������ ToShortString() � ������� ������. 

2.  ���������    ��������    ����    ������������    �    ����    Student    ���������, 
�������������    ������   �   ���������   ���    �    �������   ������    ToString()    � 
������� ������. 

3.  C  �������  ������  AddExams(params  Exam[])   ��������  ��������  � ������  
���������  �  �������  ������  �������  Student,  ���������  ����� ToString(). 

4.  �������  ���  �������  ����    Person    �  ������������  �������  �  ���������,  ��� 
������ �� ������� �� �����, � ������� �����, ������� �������� ���-����� ��� 
��������. 

5.  �������   ������    ����    Student,    ��������    ��������    �    ������    ���������    � 
�������, ������� ������ ������� Student.  

6.  ������� �������� �������� ���� Person ��� ������� ���� Student. 

7.  �   �������    ������   DeepCopy()    �������    ������    �����    �������    Student. 
��������  ������  �  ��������  �������  Student  �  �������  �����  � �������� 
������, ������ ����� ��������� ������� ������ �������� ��� ���������.  

8.  �    �����    try/catch    ���������    ��������    �    �������    ������    ������������ 
��������,  �  �����������   ����������   �������   ���������,  ���������� ����� 
������-����������.  
9.  �  �������  ���������  foreach  ������� ������ ���� ������� � ���������.  

10. �  �������  ���������  foreach  ���  ���������  �  ���������� �������  ������  
����  ���������  � ������� ���� 3.
