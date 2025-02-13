-- Query 1: Find duplicate email addresses
SELECT EMAIL
FROM PERSON 
GROUP BY EMAIL
HAVING COUNT(EMAIL) > 1;

-- Query 2: Find the second-highest salary
SELECT MAX(SALARY) AS SecondHighestSalary
FROM EMPLOYEE
WHERE SALARY < (SELECT MAX(SALARY) FROM EMPLOYEE);

-- Query 3: Get top 3 highest salaries per department
SELECT D.name AS Department, E.name AS Employee, E.salary AS Salary
FROM Department D
JOIN Employee E 
    ON E.departmentId = D.id
WHERE e.salary IN (
        SELECT DISTINCT TOP 3 salary
        FROM Employee E2
        WHERE E2.departmentId = D.id
        ORDER BY salary DESC
    )
ORDER BY Department, Salary DESC;
