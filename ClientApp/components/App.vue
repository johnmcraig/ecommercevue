<template>
    <div>
        <h1>Welcome to Hands on Vue.js with ASP.NET Core 2.1!</h1>
        <p>The time now is: {{ time }}</p>
        <p>The current users of our system are:
            <ul>
                <li v-for="user in users" :key="user.userName">
                    {{ user.fullName }} - {{ user.userName }}
                </li>
            </ul>
        </p>
    </div>
</template>

<script>
export default {
    name: 'app',
    data () {
        return {
            time: new Date().toString(),
            users: []
        }
    },
    mounted () {
        fetch('/api/users').then(response => {
            return response.json()
        })
        .then(data => {
            this.users = data
        })
    }
}
</script>
