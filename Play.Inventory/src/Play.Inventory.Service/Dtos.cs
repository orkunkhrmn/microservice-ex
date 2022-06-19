using System;

namespace Play.Inventory.Service.Dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatologItemId, int Quantity);
    public record InventoryItemDto(Guid CatologItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);
    public record CatalogItemDto(Guid Id, string Name, string Description);
}