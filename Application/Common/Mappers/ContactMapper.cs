using Application.Common.Models;
using AutoMapper;
using Domain.Aggregates.ContactAggregate;

namespace Application.Common.Mappers;

public class ContactProfile : Profile {
    public ContactProfile() {
        CreateMap<Contact, CreateContactInputDto>();
        CreateMap<CreateContactInputDto, Contact>();
    }
}