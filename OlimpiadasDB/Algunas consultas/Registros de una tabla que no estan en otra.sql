select * from tbExamenes ex left join tbInscripciones ins on ex.ExaInscripcion=ins.InsId where ins.InsId is null;

select * from tbDetalleExamen Det left join tbExamenes Exa on Det.DetId=Exa.ExaId where Exa.ExaId is null


select * from tbDetalleExamen 

delete tbDetalleExamen where DetId <19028