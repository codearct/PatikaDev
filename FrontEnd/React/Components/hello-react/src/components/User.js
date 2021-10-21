import PropTypes from "prop-types";

function User({ name, surname, isLogin, age, friends, adress }) {

    if (!isLogin) {
        return <div>Giriş Yapmadınız!</div>
    }
    return (
        <div>
            <h1>
                {
                    `${name} ${surname} (${age})`
                }
            </h1>

            {adress.title} {adress.zip}

            <br />
            <br />

            {friends &&
                friends.map((friend) => (
                    <div key={friend.id}> {friend.name} </div>
                ))}

        </div>
    )
}

User.propTypes = {
    name: PropTypes.string.isRequired,
    surname: PropTypes.string.isRequired,
    isLogin: PropTypes.bool.isRequired,
    age: PropTypes.oneOfType([
        PropTypes.string,
        PropTypes.number,
    ]),
    friends: PropTypes.array,
    adress: PropTypes.shape({
        title: PropTypes.string,
        zip: PropTypes.number
    })
}

User.defaultProps = {
    name: "İsimsiz",
    isLogin: false
}

export default User;