function User({ name, surname, isLogin, age, friends }) {
    return (
        <div>
            <h1>
                {
                    isLogin ? `${name} ${surname} (${age})` : "Giriş Yapmadınız!"
                }
            </h1>

            {friends.map((friend) => (
                <div key={friend.id}> {friend.name} </div>
            ))}

        </div>
    )
}
export default User;