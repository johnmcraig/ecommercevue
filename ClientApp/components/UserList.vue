<template>
    <div>
        <h3>Current List of Users in the seeded Database</h3>
        <p>The current users of our system are:
            <ul>
                <li v-for="user in users" :key="user.fullName">
                    {{ user.fullName }} - {{ user.email }}
                </li>
            </ul>
        </p>
    </div>
</template>

<script>
export default {
    name: 'user-list',
    data () {
        return {
            users: []
        }  
    },
    mounted () {
        fetch('api/users').then(response => {
            return response.json()
        })
        .then(data => {
            this.users = data
        })
    }
}
</script>

<style scoped>

</style>