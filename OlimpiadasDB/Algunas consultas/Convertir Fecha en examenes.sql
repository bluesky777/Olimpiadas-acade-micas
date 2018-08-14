select E.ExaId, STR(Num) + ' - ' + CONVERT(VARCHAR(24), E.ExaFecha, 100)  as Examen 
FROM tbExamenes E, (select ROW_NUMBER() OVER(order by ExaId) as Num from tbExamenes) as n  
