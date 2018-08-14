insert into tbCatPreg(PrCaPregunta, PrCaCategoria, PrCaOrden) 
(select p.PregCodigo, p.PregCategoria, s.SelOrden 
	from tbPreguntas as p, tbSeleccion as s 
	where s.SelCategoria=p.PregCategoria and p.PregCodigo=s.SelPregunta)
	 