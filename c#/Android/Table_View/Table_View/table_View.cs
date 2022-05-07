 using Xamarin.Forms;

namespace Table_View
{
    public class table_View : ContentPage
    {
        public table_View()
        {
            Title = "Teste";
            Content = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection ( "Items" )
                    {
                        new EntryCell
                        {
                            Label = "Item",
                            Text = "Digite o Item",
                            Placeholder = "Digite o Item",
                            Keyboard = Keyboard.Text
                        },
                        new SwitchCell
                        {
                            On = true,
                            Text = "Habilitado"
                        },
                        new ViewCell
                        {
                            View = new View1()
                        }
                    }
                },
                Intent = TableIntent.Form
            };
        }
    }
}