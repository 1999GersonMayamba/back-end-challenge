# Bookstore
Web API RESTful em Asp.NET Core para gestão de livros


## Comandos EF:
* update-database -Context ApplicationDbContext (Para gerar a base de dados com toda estrutura)

Ou pode alterar o valor da key **[UseInMemoryDatabase]** para true no file  **appsettings.json**
para poder utilizar o sql in memory

## Frameworks aplicadas no projeto


<p><b>Swashbuckle.AspNetCore</b> - utilizei ela para poder implementar a documentação da API.</p>
<p><b>NLog.Config</b> - utilizei ela para poder implementar o registo de logs em files na API.</p>
<p><b>Serilog.AspNetCore</b> - utilizei ela para poder implementar logs na consola da API.</p>
<p><b>AutoMapper</b> - utilizei ela para poder ter o parse dos meus objectos de entidade de base de dados para um outro objecto com menos informações.</p>
<p> <b>Microsoft.EntityFrameworkCore.SqlServer/Microsoft.AspNetCore.Identity.EntityFrameworkCore/Microsoft.VisualStudio.Web.CodeGeneration.Design/Microsoft.EntityFrameworkCore.Tools</b> - utilizei como a ORM da minha API, para poder ter uma abstração com o banco.</p>




## Experiência com o projeto 
   <p>Teóricamente tive de indentificar todas as entidades envolvidas no problema, como foi descrito no readme do challenge, Autor, Genero, e posteriomente identificar quais informações relevantes compunha cada uma delas, tenho reunido tudo isso, passei para a implementação.</p>
   <p>Na parte pratica não tive, tive implementar alguns requistos que não foi pedido no challange mas que eu achei muito importante, como swagger para facilitar os teste e a compressão da API.</p>

## Futuro

Melhorias para o projecto são muitas, basicamente iria implementar autenticação e autorização na API, acrescentaria mais feature nela, como:
<p><b>Filtro de livros por categoria ou autor.</b></p>
<p><b>Paginação no retoro de livros, uma vez que poderemos ter muitos livros em nossa aplicação.</b></p>
<p><b>Acrescentaria mais campos para as entidades para podermos ter mais informações, como data da publicação do livro, Link da capa do livro...</b></p>
<p><b>Mais controle nos livros,  entradas e saidas de livros.</b></p>
<p><b>Implementar rede de fornecedores de livros.</b></p>
<p><b>Relarório, para se ter uma ideia geral de andam as coisas.</b></p>
<p><b>Possibilidade de vendas de livros online.</b></p>



