<!-- src/views/EventsView.vue -->
<template>
  <div class="min-h-full">
    <BaseNavbar />
    <header class="bg-white shadow-sm">
      <div class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">Events</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
        <div class="container mx-auto p-4">
          <h1 class="text-2xl font-bold mb-4">Events</h1>
          <div v-if="error" class="text-red-500">{{ error.message }}</div>
          <div v-else>
            <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
              <router-link
                  v-for="event in events"
                  :key="event.id"
                  :to="{ name: 'EventDetailedView', params: { eventId: event.id } }"
                  class="bg-white rounded-lg shadow-lg p-6 block hover:shadow-xl transition-shadow"
              >
                <h2 class="text-xl font-semibold mb-2">{{ event.title }}</h2>
                <p class="text-gray-700 mb-4">{{ event.description }}</p>
                <p class="text-gray-700">Ticket price: {{ event.regularPrice }}</p>
                <p class="text-gray-700">Vip ticket price: {{ event.vipPrice }}</p>
              </router-link>
            </div>
          </div>
        </div>
      </div>
    </main>
  </div>
</template>

<script setup>
import { onMounted } from 'vue';
import BaseNavbar from '../components/BaseNavbar.vue';
import { useEvents } from '../composables/useEvents';

const { events, error, fetchEvents } = useEvents();

onMounted(() => {
  fetchEvents();
});
</script>
