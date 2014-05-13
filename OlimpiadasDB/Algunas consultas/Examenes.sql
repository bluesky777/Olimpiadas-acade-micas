
select ExaId, u.UsuCodigo, UsuNombre, CatNombreCorto, ExaCantPreg, Det.CantContestadas, Det.CantCorrec
from tbEventos ev, tbCategorias c, tbInscripciones i, 
tbExamenes ex, tbEntidades en, tbUsuarios u, 
(select  count(D.DetPregunta) as CantContestadas, count(D.DetContestada) as CantCorrec 
	from tbDetalleExamen D, tbExamenes E where D.DetExamen=E.ExaId group by D.DetExamen ) as Det 
where ev.EvId=c.CatEvento and c.CatId=i.InsCategoria and i.InsId=ex.ExaInscripcion 
and u.UsuCodigo=i.InsUsuario and en.EntId=i.InsEntidad  and en.EntId=1 and c.CatId=19  
and Det.DetExamen=ExaId 
and ex.ExaFecha >='13/08/2012 20:16' and ex.ExaFecha <= '17/08/2012 20:16' 


Select count(D.DetPregunta) as CantContestadas, count(D.DetContestada) as CantCorrec from tbDetalleExamen D where D.DetExamen=34