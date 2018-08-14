SELECT num as 'No', t4.PregPregunta as Pregunta, t4.PregRespCorrecta as Correcta, 
Case t3.DetContestada when 'RespCorrec' then 'CORRECTA' else  t3.DetContestada end as 'Opcion Contestada', 
Case t3.DetContestada when 'RespCorrec' then t4.PregRespCorrecta when 'Resp2' then t4.PregResp2 
	when 'Resp3' then t4.PregResp2 when 'Resp4' then t4.PregResp4 
	end AS 'Respuesta Contestada', t3.DetTiempo as Tiempo 
FROM (select DetExamen, DetPregunta, ROW_NUMBER() OVER(order by DetId ) as num 
	from tbDetalleExamen where DetExamen='1187') AS Orden, 
	tbUsuarios t0 JOIN tbInscripciones t1 ON t0.UsuCodigo=t1.InsUsuario 
	JOIN tbExamenes t2 ON t2.ExaInscripcion=t1.InsId 
	JOIN tbDetalleExamen t3 ON t3.DetExamen  = t2.ExaId JOIN tbPreguntas t4 
ON t4.PregCodigo  = t3.DetPregunta 
where t3.DetExamen = '1187'  and Orden.DetExamen=t3.DetExamen and Orden.DetPregunta=t4.PregCodigo 

