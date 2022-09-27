using Observer;

OrderItemViewModel viewModel = new OrderItemViewModel("Shoes");
OrderItemView view = new OrderItemView(viewModel);

viewModel.View = view;

view.ClickIncreaseQuantityButton();

viewModel.Quantity = 5;

Console.ReadKey();