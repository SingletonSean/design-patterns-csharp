using Observer;

OrderItemViewModel viewModel = new OrderItemViewModel("Shoes");
OrderItemView view = new OrderItemView(viewModel);

view.ClickIncreaseQuantityButton();

viewModel.Quantity = 5;

view.Dispose();

Console.ReadKey();