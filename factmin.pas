var i:longint;
    fact:real;
begin
    i:=1;
    fact:=1;
    while (fact<>0) do begin
        writeln(i,' ',fact);
        i:=i+1;
        fact:=fact/i;
    end;
end.
//178
