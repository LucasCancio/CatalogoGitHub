using Catalogo_GitHub.Models;
using GraphQL.Types;

namespace Catalogo_GitHub.Types
{
    public class RepositorioType : ObjectGraphType<Repositorio>
    {
        public RepositorioType()
        {
            Field(x => x.id);
            Field(x => x.name);
            Field(x => x.html_url);
            Field(x => x.url);
            Field(x => x.description);
        }
    }
}
