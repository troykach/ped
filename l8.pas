var k:longint;
    i:integer;
    x,factobr,sum:real;
begin
    read(k,x);
    i:=1;
    factobr:=1;
    sum:=1;
    for i:=1 to k do begin
	factobr:=factobr/i;
        sum:=sum+(cos(i*x)*factobr);
        if i=177 then break;
        end;
    write(sum);
end.
