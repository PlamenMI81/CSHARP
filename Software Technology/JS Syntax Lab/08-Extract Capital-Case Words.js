function extract(arr) {
    let text=arr.join(",");
    let tokens=text.split(/\W+/);
    tokens=tokens.filter(w=>w.length>0);
    let capsTokens=[];

    function isCaps(token) {
        for(let i=0;i<token.length;i++){
            if(token[i]!==token[i].toUpperCase()){
                return false;
            }
        }
        return true;
    }

    for(let token of tokens){
        if(isCaps(token)){
            capsTokens.push(token);
        }
    }
    console.log(capsTokens.join(", "));

}

extract(['Later we play with C#, EF, SQL Server and ASP.NET MVC.',
    'Finally, we touch some Java, Hibernate and Spring.MVC.']);