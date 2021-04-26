using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                "paginas",
                "paginas",
                new { controller = "Paginas", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "cadastro",
                "paginas/cadastro",
                new { controller = "Paginas", action = "Cadastro", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "criar",
                "paginas/criar",
                new { controller = "Paginas", action = "Criar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "editar",
                "paginas/{id}/editar",
                new { controller = "Paginas", action = "Editar", id = 0 }
            );

            routes.MapRoute(
                "alterar",
                "paginas/{id}/alterar",
                new { controller = "Paginas", action = "Alterar", id = 0 }
            );

            routes.MapRoute(
                "excluir",
                "paginas/{id}/excluir",
                new { controller = "Paginas", action = "Excluir", id = 0 }
            );
              
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
