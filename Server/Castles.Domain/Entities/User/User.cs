using CSharpFunctionalExtensions;

namespace Castles.Domain.Entities.User;

public enum Gender {
    Male,
    Female,
    Unset,
}

public enum Role {
    User,
    Premuim,
    Admin,
}

public record class User {
    private User() { }
    public UInt64 Id { get; init; }
    public required String Username { get; init; }
    public static Result<User> Create(
            String username,
            String email,
            String password,
            String status,
            Gender gender = Gender.Unset,
            Role role = Role.User) {

    }
}

