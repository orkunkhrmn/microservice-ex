using System;

namespace Play.Inventory.Service.Dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatologItemId, int Quantity);
    public record InventoryItemDto(Guid CatologItemId, int Quantity, DateTimeOffset AcquiredDate);
}