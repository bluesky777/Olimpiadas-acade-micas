/*create table tbNueva (CodPreg numeric(18, 0), CodCat numeric(18, 0), Orden numeric(18, 0))
*/

insert into tbNueva (CodPreg, CodCat, Orden)
	select PregCodigo , 20, ABS(CAST(NEWID() as binary(6)) % 4) + 1
	from tbPreguntas , tbCatPreg 
	where PregCodigo=PrCaPregunta and PrCaCategoria=2
