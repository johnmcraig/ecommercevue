<template>
    <div>
        <navbar/>
            <transition name="fade" mode="out-in">
                <router-view/>
            </transition>
    </div>
</template>

<script>
import Navbar from './components/Navbar'

export default {
    name: 'App',
    components: {
        Navbar
    } 
}
</script>
