namespace Presentation.DTOs
{
    public class AuthenticationResponseDto
    {
        /// <summary>
        /// Represents the authentication token that is generated after a successful authentication. This token is usually used for subsequent API requests to authenticate the user.
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// Represents a refresh token that can be used to request a new authentication token without requiring the user to re-authenticate. This is typically used in scenarios where the authentication token has expired.
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// Represents the expiration time of the authentication token. This property indicates when the authentication token will no longer be valid and a new token will be required.
        /// </summary>
        public DateTime Expiration { get; set; }
    }

}
