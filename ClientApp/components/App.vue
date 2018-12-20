<template>
    <div>
        <h1>Welcome to Hands on Vue.js with ASP.NET Core 2.1!</h1>
        <p>The time now is: {{ time }}</p>
    </div>
</template>

<script>
export default {
    name: 'app',
    data () {
        return {
            time: new Date().toString()
        }
    }
}
</script>
